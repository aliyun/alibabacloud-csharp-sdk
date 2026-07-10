// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeInfoCheckExportRecordRequest : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-11 21:24:48</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ID_CARD_2_META</b>: ID card two-element verification.</description></item>
        /// <item><description><b>ID_PERIOD</b>: ID card validity period verification.</description></item>
        /// <item><description><b>MOBILE_ONLINE_LENGTH</b>: mobile number online duration.</description></item>
        /// <item><description><b>MOBILE_ONLINE_STATUS</b>: mobile number online status.</description></item>
        /// <item><description><b>MOBILE_3_META_SIMPLE</b>: mobile number three-element verification (simple edition).</description></item>
        /// <item><description><b>MOBILE_3_META</b>: mobile number three-element verification (detailed edition).</description></item>
        /// <item><description><b>MOBILE_2_META</b>: mobile number two-element verification.</description></item>
        /// <item><description><b>BANK_CARD_N_META</b>: bank card verification (detailed edition).</description></item>
        /// <item><description><b>MOBILE_DETECT</b>: phone number detection.</description></item>
        /// <item><description><b>VEHICLE_N_META</b>: vehicle element verification (enhanced edition).</description></item>
        /// <item><description><b>VEHICLE_PENTA_INFO</b>: vehicle five-element information recognition.</description></item>
        /// <item><description><b>VEHICLE_LICENSE_INFO</b>: vehicle information recognition.</description></item>
        /// <item><description><b>VEHICLE_INSURE_DATE</b>: vehicle insurance date query.</description></item>
        /// <item><description><b>VEHICLE_CHECK</b>: vehicle element verification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ID_CARD_2_META</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The start time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-11 21:24:48</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
