/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the AcknowledgeJob operation.
    /// Returns information about a specified job and whether that job has been received by
    /// the job worker. Only used for custom actions.
    /// </summary>
    public partial class AcknowledgeJobRequest : AmazonCodePipelineRequest
    {
        private string _jobId;
        private string _nonce;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique system-generated ID of the job for which you want to confirm receipt.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property Nonce. 
        /// <para>
        /// A system-generated random number that AWS CodePipeline uses to ensure that the job
        /// is being worked on by only one job worker. This number must be returned in the response.
        /// </para>
        /// </summary>
        public string Nonce
        {
            get { return this._nonce; }
            set { this._nonce = value; }
        }

        // Check to see if Nonce property is set
        internal bool IsSetNonce()
        {
            return this._nonce != null;
        }

    }
}