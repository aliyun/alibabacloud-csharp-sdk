// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeMetaStatisticsPageListRequest : TeaModel {
        /// <summary>
        /// <para>Product API:</para>
        /// <list type="bullet">
        /// <item><description><b>ID_CARD_2_META</b>: ID Card Two-Element Verification</description></item>
        /// <item><description><b>ID_PERIOD</b>: ID Card Validity Verification Period</description></item>
        /// <item><description><b>MOBILE_ONLINE_LENGTH</b>: Mobile Online Duration</description></item>
        /// <item><description><b>MOBILE_ONLINE_STATUS</b>: Mobile Online Status</description></item>
        /// <item><description><b>MOBILE_3_META_SIMPLE</b>: Mobile Number Three-Element Verification (Simple)</description></item>
        /// <item><description><b>MOBILE_3_META</b>: Mobile Number Three-Element Verification (Detailed)</description></item>
        /// <item><description><b>MOBILE_2_META</b>: Mobile Number Two-Element Verification</description></item>
        /// <item><description><b>BANK_CARD_N_META</b>: Bank Card Verification (Detailed)</description></item>
        /// <item><description><b>MOBILE_DETECT</b>: Number Detection</description></item>
        /// <item><description><b>VEHICLE_N_META</b>: Vehicle Element Verification (Enhanced)</description></item>
        /// <item><description><b>VEHICLE_PENTA_INFO</b>: Vehicle Five-Element Information Recognition</description></item>
        /// <item><description><b>VEHICLE_LICENSE_INFO</b>: Vehicle Information Recognition</description></item>
        /// <item><description><b>VEHICLE_INSURE_DATE</b>: Vehicle Insurance Date Query</description></item>
        /// <item><description><b>VEHICLE_CHECK</b>: Vehicle Element Verification</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_PERIOD</para>
        /// </summary>
        [NameInMap("Api")]
        [Validation(Required=false)]
        public string Api { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Query end time. Unix timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1737561599999</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>Number of data entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Query start time. The timestamp is in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760112000000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}
