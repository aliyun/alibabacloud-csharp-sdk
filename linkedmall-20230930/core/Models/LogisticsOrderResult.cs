// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LogisticsOrderResult : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>菜鸟</para>
        /// </summary>
        [NameInMap("dataProvider")]
        [Validation(Required=false)]
        public string DataProvider { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>菜鸟裹裹</para>
        /// </summary>
        [NameInMap("dataProviderTitle")]
        [Validation(Required=false)]
        public string DataProviderTitle { get; set; }

        [NameInMap("goods")]
        [Validation(Required=false)]
        public List<Good> Goods { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SF （OTHER-其他 POST-中国邮政 EMS-EMS EYB-EMS快递包裹 POSTB-邮政快递包裹 STO-申通快递 YTO-圆通快递 YUNDA-韵达快递 ZJS-宅急送 FEDEX-联邦快递 DBKD-德邦物流 SHQ-华强物流 TN-特能 TAOBAO-淘宝物流 ZTO-中通快递 HTKY-百世快递 TTKDEX-天天快递 SF-顺丰速运 ZTKY-中铁物流 QFKD-全峰快递 JT-极兔物流）</para>
        /// </summary>
        [NameInMap("logisticsCompanyCode")]
        [Validation(Required=false)]
        public string LogisticsCompanyCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>顺丰</para>
        /// </summary>
        [NameInMap("logisticsCompanyName")]
        [Validation(Required=false)]
        public string LogisticsCompanyName { get; set; }

        [NameInMap("logisticsDetailList")]
        [Validation(Required=false)]
        public List<LogisticsDetail> LogisticsDetailList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SF234***2345</para>
        /// </summary>
        [NameInMap("mailNo")]
        [Validation(Required=false)]
        public string MailNo { get; set; }

    }

}
