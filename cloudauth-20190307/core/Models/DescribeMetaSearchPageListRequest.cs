// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeMetaSearchPageListRequest : TeaModel {
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
        /// <item><description><b>VEHICLE_CHECK</b>: vehicle element verification.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_CARD_2_META</para>
        /// </summary>
        [NameInMap("Api")]
        [Validation(Required=false)]
        public string Api { get; set; }

        /// <summary>
        /// <para>The bank card number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>610*************1181</para>
        /// </summary>
        [NameInMap("BankCard")]
        [Validation(Required=false)]
        public string BankCard { get; set; }

        /// <summary>
        /// <para>The verification status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Verification passed.</description></item>
        /// <item><description><b>2</b>: Verification failed.</description></item>
        /// <item><description><b>3</b>: No record found.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1739926800000</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>The ID card number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>522132197411184XXX</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The name of the telecommunications service provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CMCC</b>: China Mobile</description></item>
        /// <item><description><b>CUCC</b>: China Unicom</description></item>
        /// <item><description><b>CTCC</b>: China Telecom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CTCC</para>
        /// </summary>
        [NameInMap("IspName")]
        [Validation(Required=false)]
        public string IspName { get; set; }

        /// <summary>
        /// <para>The mobile phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19127612221</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B012DB99-6C10-5740-81E0-B3A8C1C1B9C1</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760198400000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>The result code. For more information, see <a href="https://www.alibabacloud.com/help/en/id-verification/information-verification/">official documentation</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>205</para>
        /// </summary>
        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The license plate number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>陕A9****</para>
        /// </summary>
        [NameInMap("VehicleNum")]
        [Validation(Required=false)]
        public string VehicleNum { get; set; }

    }

}
