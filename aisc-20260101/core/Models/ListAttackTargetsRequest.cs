// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class ListAttackTargetsRequest : TeaModel {
        /// <summary>
        /// <para>The upper bound (inclusive) of the first scan time range. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735689600000</para>
        /// </summary>
        [NameInMap("FirstScanTimeEnd")]
        [Validation(Required=false)]
        public string FirstScanTimeEnd { get; set; }

        /// <summary>
        /// <para>The lower bound (inclusive) of the first scan time range. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735689600000</para>
        /// </summary>
        [NameInMap("FirstScanTimeStart")]
        [Validation(Required=false)]
        public string FirstScanTimeStart { get; set; }

        /// <summary>
        /// <para>Filters targets by the status of the most recent scan task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>completed</para>
        /// </summary>
        [NameInMap("LastScanStatus")]
        [Validation(Required=false)]
        public string LastScanStatus { get; set; }

        /// <summary>
        /// <para>The upper bound (inclusive) of the last scan time range. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735689600000</para>
        /// </summary>
        [NameInMap("LastScanTimeEnd")]
        [Validation(Required=false)]
        public string LastScanTimeEnd { get; set; }

        /// <summary>
        /// <para>The lower bound (inclusive) of the last scan time range. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735689600000</para>
        /// </summary>
        [NameInMap("LastScanTimeStart")]
        [Validation(Required=false)]
        public string LastScanTimeStart { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Values less than 1 are normalized to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100. Values greater than 100 are clamped to 100. Values less than 1 return HTTP status code 400.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Filters targets by the exact business label of the model or agent provider. This parameter is decoupled from ConnectionMethod (technical protocol).</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>Filters targets by the risk level derived from the most recent completed scan task. Targets that have never been scanned do not have a risk level and are not matched by any value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Only the following three aggregate fields are supported. Sorting is performed in memory. If this parameter is not specified, no additional sorting is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lastScanTime</para>
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// <para>The sort order. Targets with null aggregate values are always placed last regardless of the sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>Filters targets by name using fuzzy match (substring match). If this parameter is not specified, all targets are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bailian</para>
        /// </summary>
        [NameInMap("TargetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

        /// <summary>
        /// <para>Filters targets by the exact scan target type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
