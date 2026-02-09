// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryMscpRiskInfoRequest : TeaModel {
        /// <summary>
        /// <para>ApdidToken</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApdidToken</para>
        /// </summary>
        [NameInMap("ApdidToken")]
        [Validation(Required=false)]
        public string ApdidToken { get; set; }

        /// <summary>
        /// <para>AppId</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>TenantId</para>
        /// 
        /// <b>Example:</b>
        /// <para>TenantId</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>TerminalType</para>
        /// 
        /// <b>Example:</b>
        /// <para>TerminalType</para>
        /// </summary>
        [NameInMap("TerminalType")]
        [Validation(Required=false)]
        public string TerminalType { get; set; }

        /// <summary>
        /// <para>WorkspaceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>WorkspaceId</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
