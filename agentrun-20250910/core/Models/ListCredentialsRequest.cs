// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListCredentialsRequest : TeaModel {
        /// <summary>
        /// <para>credentialAuthType</para>
        /// 
        /// <b>Example:</b>
        /// <para>credentialAuthType</para>
        /// </summary>
        [NameInMap("credentialAuthType")]
        [Validation(Required=false)]
        public string CredentialAuthType { get; set; }

        /// <summary>
        /// <para>credentialName</para>
        /// 
        /// <b>Example:</b>
        /// <para>credentialName</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>credentialSourceType</para>
        /// 
        /// <b>Example:</b>
        /// <para>credentialSourceType</para>
        /// </summary>
        [NameInMap("credentialSourceType")]
        [Validation(Required=false)]
        public string CredentialSourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}
