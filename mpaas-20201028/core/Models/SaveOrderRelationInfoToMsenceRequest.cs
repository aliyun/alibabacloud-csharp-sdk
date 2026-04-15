// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class SaveOrderRelationInfoToMsenceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ALIPUBE5C3F6D091419</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3929520</para>
        /// </summary>
        [NameInMap("BizOrderId")]
        [Validation(Required=false)]
        public string BizOrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BizOrderStatus")]
        [Validation(Required=false)]
        public int? BizOrderStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_custom_id</para>
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123321</para>
        /// </summary>
        [NameInMap("MiniProgramId")]
        [Validation(Required=false)]
        public string MiniProgramId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OpenUid")]
        [Validation(Required=false)]
        public string OpenUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mPaaS_Goosefish</para>
        /// </summary>
        [NameInMap("PlatformId")]
        [Validation(Required=false)]
        public string PlatformId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NPHTGKNR</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
