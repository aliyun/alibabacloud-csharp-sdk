// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateKBSyncLinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cli_xxxxxxbe8</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testDesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkb-xxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("LinkName")]
        [Validation(Required=false)]
        public string LinkName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.feishu.cn/wiki/space/xxxxxx">https://example.feishu.cn/wiki/space/xxxxxx</a></para>
        /// </summary>
        [NameInMap("SourceDir")]
        [Validation(Required=false)]
        public string SourceDir { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEISHU</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("SyncIntervalMinutes")]
        [Validation(Required=false)]
        public int? SyncIntervalMinutes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>63eexxxx-xxxx-xxxx-xxxx-xxxxxx090f82</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
