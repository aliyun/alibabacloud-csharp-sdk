// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LogisticsOrderResult : TeaModel {
        /// <summary>
        /// <para>The data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cainiao</para>
        /// </summary>
        [NameInMap("dataProvider")]
        [Validation(Required=false)]
        public string DataProvider { get; set; }

        /// <summary>
        /// <para>The data text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cainiao Guoguo</para>
        /// </summary>
        [NameInMap("dataProviderTitle")]
        [Validation(Required=false)]
        public string DataProviderTitle { get; set; }

        /// <summary>
        /// <para>The product details.</para>
        /// </summary>
        [NameInMap("goods")]
        [Validation(Required=false)]
        public List<Good> Goods { get; set; }

        /// <summary>
        /// <para>The logistics company code.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ZTKY: China Railway Logistics</description></item>
        /// <item><description>POST: China Post</description></item>
        /// <item><description>DBKD: Deppon Express</description></item>
        /// <item><description>JT: J&amp;T Express</description></item>
        /// <item><description>QFKD: Quanfeng Express</description></item>
        /// <item><description>EYB: China Post E-commerce Express EYB</description></item>
        /// <item><description>STO: STO Express</description></item>
        /// <item><description>SF: SF Express</description></item>
        /// <item><description>ZTO: ZTO Express</description></item>
        /// <item><description>YTO: YTO Express</description></item>
        /// <item><description>TTKDEX: Tiantian Express</description></item>
        /// <item><description>JDLEx: JD Express</description></item>
        /// <item><description>ETICKET: Electronic vouchers</description></item>
        /// <item><description>HTKY: Best Express</description></item>
        /// <item><description>SHQ: Huaqiang Logistics</description></item>
        /// <item><description>TAOBAO: Taobao Logistics</description></item>
        /// <item><description>YUNDA: Yunda Express</description></item>
        /// <item><description>ZJS: ZJS Express</description></item>
        /// <item><description>FEDEX: FedEx</description></item>
        /// <item><description>EMS: EMS</description></item>
        /// <item><description>POSTB: China Post Parcel</description></item>
        /// <item><description>OTHER: Other</description></item>
        /// <item><description>CNDJWL: Cainiao Large Item Logistics</description></item>
        /// <item><description>TN: Teneng</description></item>
        /// <item><description>ZMKM: Cainiao Express</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SF</para>
        /// </summary>
        [NameInMap("logisticsCompanyCode")]
        [Validation(Required=false)]
        public string LogisticsCompanyCode { get; set; }

        /// <summary>
        /// <para>The logistics company name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SF Express</para>
        /// </summary>
        [NameInMap("logisticsCompanyName")]
        [Validation(Required=false)]
        public string LogisticsCompanyName { get; set; }

        /// <summary>
        /// <para>The logistics details.</para>
        /// </summary>
        [NameInMap("logisticsDetailList")]
        [Validation(Required=false)]
        public List<LogisticsDetail> LogisticsDetailList { get; set; }

        /// <summary>
        /// <para>The logistics tracking number.</para>
        /// <remarks>
        /// <para>The logistics tracking number for electronic vouchers is a fixed value: *.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SF234***2345</para>
        /// </summary>
        [NameInMap("mailNo")]
        [Validation(Required=false)]
        public string MailNo { get; set; }

    }

}
