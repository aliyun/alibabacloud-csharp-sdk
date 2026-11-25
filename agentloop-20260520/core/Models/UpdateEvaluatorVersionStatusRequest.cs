// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateEvaluatorVersionStatusRequest : TeaModel {
        /// <summary>
        /// <para>The expected current status. Valid values: DRAFT, PUBLISHED, and OFFLINE. If the specified value does not match the actual status, the API operation returns a 409 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("expectedStatus")]
        [Validation(Required=false)]
        public string ExpectedStatus { get; set; }

        /// <summary>
        /// <para>The target status. PUBLISHED indicates publishing a draft for the first time or bringing an offline version back online. OFFLINE indicates taking a published version offline.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLISHED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The version number to update. The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v3</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The version description that you can provide when publishing a draft for the first time. The maximum length is 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Added scoring rules for answer accuracy</para>
        /// </summary>
        [NameInMap("versionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

    }

}
