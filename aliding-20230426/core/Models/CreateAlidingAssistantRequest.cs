// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateAlidingAssistantRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f5cb37a0fb44441ab7b74c6f4a679dd3</para>
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, string> Ext { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@lADPDetfgMsFFUvNAkjNAkg</para>
        /// </summary>
        [NameInMap("Icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RecommendPrompts")]
        [Validation(Required=false)]
        public List<string> RecommendPrompts { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public int? Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chatBot-123</para>
        /// </summary>
        [NameInMap("SourceIdentityId")]
        [Validation(Required=false)]
        public string SourceIdentityId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateAlidingAssistantRequestTenantContext TenantContext { get; set; }
        public class CreateAlidingAssistantRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WelcomeContent")]
        [Validation(Required=false)]
        public string WelcomeContent { get; set; }

    }

}
