// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class BatchAssignSeatsRequest : TeaModel {
        /// <summary>
        /// <para>The list of target member IDs.</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// <para>The AccountIds in string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;5854302538759072\&quot;]</para>
        /// </summary>
        [NameInMap("AccountIdsStr")]
        [Validation(Required=false)]
        public string AccountIdsStr { get; set; }

        /// <summary>
        /// <para>The account ID of the caller that identifies the initiator of this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acc_123456789</para>
        /// </summary>
        [NameInMap("CallerUacAccountId")]
        [Validation(Required=false)]
        public string CallerUacAccountId { get; set; }

        /// <summary>
        /// <para>The language setting. Valid values: zh-CN and en-US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        /// <summary>
        /// <para>The product namespace ID. For the TokenPlan product, this field is fixed to namespace-1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace-1</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The seat type. Valid values: standard, pro, and max.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("SeatType")]
        [Validation(Required=false)]
        public string SeatType { get; set; }

        /// <summary>
        /// <para>The ID of the target workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws_123456789</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
