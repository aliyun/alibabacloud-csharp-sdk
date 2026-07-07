// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LogisticsOrderResult : TeaModel {
        /// <summary>
        /// <para>The data provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>菜鸟</para>
        /// </summary>
        [NameInMap("dataProvider")]
        [Validation(Required=false)]
        public string DataProvider { get; set; }

        /// <summary>
        /// <para>The display title of the data provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>菜鸟裹裹</para>
        /// </summary>
        [NameInMap("dataProviderTitle")]
        [Validation(Required=false)]
        public string DataProviderTitle { get; set; }

        /// <summary>
        /// <para>Details of the goods.</para>
        /// </summary>
        [NameInMap("goods")]
        [Validation(Required=false)]
        public List<Good> Goods { get; set; }

        /// <summary>
        /// <para>The logistics company code.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ZTKY</c> - China Railway Logistics</para>
        /// </description></item>
        /// <item><description><para><c>POST</c> - China Post</para>
        /// </description></item>
        /// <item><description><para><c>DBKD</c> - Deppon Express</para>
        /// </description></item>
        /// <item><description><para><c>JT</c> - J\&amp;T Express</para>
        /// </description></item>
        /// <item><description><para><c>QFKD</c> - Quanfeng Express</para>
        /// </description></item>
        /// <item><description><para><c>EYB</c> - China Post E-commerce Express</para>
        /// </description></item>
        /// <item><description><para><c>STO</c> - STO Express</para>
        /// </description></item>
        /// <item><description><para><c>SF</c> - SF Express</para>
        /// </description></item>
        /// <item><description><para><c>ZTO</c> - ZTO Express</para>
        /// </description></item>
        /// <item><description><para><c>YTO</c> - YTO Express</para>
        /// </description></item>
        /// <item><description><para><c>TTKDEX</c> - Tiantian Express</para>
        /// </description></item>
        /// <item><description><para><c>JDLEx</c> - JD Express</para>
        /// </description></item>
        /// <item><description><para><c>ETICKET</c> - e-ticket</para>
        /// </description></item>
        /// <item><description><para><c>HTKY</c> - Best Express</para>
        /// </description></item>
        /// <item><description><para><c>SHQ</c> - Huaqiang Logistics</para>
        /// </description></item>
        /// <item><description><para><c>TAOBAO</c> - Taobao Logistics</para>
        /// </description></item>
        /// <item><description><para><c>YUNDA</c> - Yunda Express</para>
        /// </description></item>
        /// <item><description><para><c>ZJS</c> - ZJS Express</para>
        /// </description></item>
        /// <item><description><para><c>FEDEX</c> - FedEx</para>
        /// </description></item>
        /// <item><description><para><c>EMS</c> - EMS</para>
        /// </description></item>
        /// <item><description><para><c>POSTB</c> - China Post Parcel</para>
        /// </description></item>
        /// <item><description><para><c>OTHER</c> - other</para>
        /// </description></item>
        /// <item><description><para><c>CNDJWL</c> - Cainiao Heavy Parcel Logistics</para>
        /// </description></item>
        /// <item><description><para><c>TN</c> - T-neng Logistics</para>
        /// </description></item>
        /// <item><description><para><c>ZMKM</c> - Cainiao Express</para>
        /// </description></item>
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
        /// <para>The name of the logistics company.</para>
        /// 
        /// <b>Example:</b>
        /// <para>顺丰</para>
        /// </summary>
        [NameInMap("logisticsCompanyName")]
        [Validation(Required=false)]
        public string LogisticsCompanyName { get; set; }

        /// <summary>
        /// <para>A list of logistics details.</para>
        /// </summary>
        [NameInMap("logisticsDetailList")]
        [Validation(Required=false)]
        public List<LogisticsDetail> LogisticsDetailList { get; set; }

        /// <summary>
        /// <para>The tracking number.</para>
        /// <remarks>
        /// <para>For an e-ticket, the tracking number is a fixed value: \*</para>
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
