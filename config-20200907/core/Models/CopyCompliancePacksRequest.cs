// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CopyCompliancePacksRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the destination account groups into which the compliance packages are replicated. Separate multiple account group IDs with commas (,).</para>
        /// <remarks>
        /// <para>If this parameter is left empty, the compliance packages are replicated to the current account group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ca-c73c626622af00f8****</para>
        /// </summary>
        [NameInMap("DesAggregatorIds")]
        [Validation(Required=false)]
        public string DesAggregatorIds { get; set; }

        /// <summary>
        /// <para>The ID of the account group to which the compliance packages belong.</para>
        /// <para>For more information about how to obtain the ID of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-05e6626622af0050****</para>
        /// </summary>
        [NameInMap("SrcAggregatorId")]
        [Validation(Required=false)]
        public string SrcAggregatorId { get; set; }

        /// <summary>
        /// <para>The IDs of the compliance packages. Separate multiple compliance package IDs with commas (,).</para>
        /// <para>For more information about how to obtain the ID of a compliance package, see <a href="https://help.aliyun.com/document_detail/263332.html">ListCompliancePacks</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-4c02626622af0050****,cp-47c1626622af0050****</para>
        /// </summary>
        [NameInMap("SrcCompliancePackIds")]
        [Validation(Required=false)]
        public string SrcCompliancePackIds { get; set; }

    }

}
