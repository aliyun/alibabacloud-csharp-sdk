// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTicketsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>223468****</para>
        /// </summary>
        [NameInMap("CaseId")]
        [Validation(Required=false)]
        public long? CaseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CaseStatus")]
        [Validation(Required=false)]
        public int? CaseStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1223</para>
        /// </summary>
        [NameInMap("CaseType")]
        [Validation(Required=false)]
        public int? CaseType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>02acfefd3fa14049826ac1a89e1xxxxx</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public int? ChannelType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DealId")]
        [Validation(Required=false)]
        public long? DealId { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>29506</para>
        /// </summary>
        [NameInMap("SrType")]
        [Validation(Required=false)]
        public long? SrType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public int? TaskStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15030609</para>
        /// </summary>
        [NameInMap("TouchId")]
        [Validation(Required=false)]
        public long? TouchId { get; set; }

    }

}
