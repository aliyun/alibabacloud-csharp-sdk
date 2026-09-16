// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeMetaStatisticsPageListRequest : TeaModel {
        /// <summary>
        /// <para>The product API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ID_CARD_2_META</b>: ID card two-element verification</description></item>
        /// <item><description><b>ID_PERIOD</b>: ID card validity period verification</description></item>
        /// <item><description><b>MOBILE_ONLINE_LENGTH</b>: mobile number online duration</description></item>
        /// <item><description><b>MOBILE_ONLINE_STATUS</b>: mobile number online status</description></item>
        /// <item><description><b>MOBILE_3_META_SIMPLE</b>: mobile number three-element verification (simple edition)</description></item>
        /// <item><description><b>MOBILE_3_META</b>: mobile number three-element verification (detailed edition)</description></item>
        /// <item><description><b>MOBILE_2_META</b>: mobile number two-element verification</description></item>
        /// <item><description><b>BANK_CARD_N_META</b>: bank card verification (detailed edition)</description></item>
        /// <item><description><b>MOBILE_DETECT</b>: phone number detection </description></item>
        /// <item><description><b>VEHICLE_N_META</b>: vehicle element verification (enhanced edition)</description></item>
        /// <item><description><b>VEHICLE_PENTA_INFO</b>: vehicle five-element information recognition</description></item>
        /// <item><description><b>VEHICLE_LICENSE_INFO</b>: vehicle information recognition</description></item>
        /// <item><description><b>VEHICLE_INSURE_DATE</b>: vehicle insurance date query</description></item>
        /// <item><description><b>VEHICLE_CHECK</b>: vehicle element verification</description></item>
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
        /// <para>The current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1737561599999</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query. The timestamp is in milliseconds.</para>
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
