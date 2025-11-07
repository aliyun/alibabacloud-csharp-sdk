// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>Whether the age is over 14 years old:</para>
        /// <list type="bullet">
        /// <item><description><b>T</b>: Over</description></item>
        /// <item><description><b>F</b>: Under</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("AgeGt")]
        [Validation(Required=false)]
        public string AgeGt { get; set; }

        /// <summary>
        /// <para>End date of the query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760630399999</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>Product Code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_PRO</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Service type:</para>
        /// <list type="bullet">
        /// <item><description><b>antcloudauth</b>: Financial-grade real-person authentication.</description></item>
        /// <item><description><b>cloudauthst</b> (discontinued): Enhanced real-person authentication.</description></item>
        /// <item><description><b>cloudauth</b> (discontinued): Real-person authentication.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>antcloudauth</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>Start date of the query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760025600000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}
