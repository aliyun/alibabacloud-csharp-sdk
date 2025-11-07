// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class QueryVerifyInvokeSatisticRequest : TeaModel {
        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>End date of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1761926399999</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>Number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>List of product codes to query. Please refer to the productCode under the corresponding ProductType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_PRO</para>
        /// </summary>
        [NameInMap("ProductProgramList")]
        [Validation(Required=false)]
        public string ProductProgramList { get; set; }

        /// <summary>
        /// <para>Product type:</para>
        /// <list type="bullet">
        /// <item><description><b>FINANCE_VERIFY</b>: Financial-grade real-person verification</description></item>
        /// <item><description><b>SMART_VERIFY</b>: Enhanced real-person verification (discontinued)</description></item>
        /// <item><description><b>FACE_VERIFY</b>: Real-person verification (discontinued)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FINANCE_VERIFY</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>List of application scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("SceneIdList")]
        [Validation(Required=false)]
        public string SceneIdList { get; set; }

        /// <summary>
        /// <para>Start date of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743436800000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>Statistics dimension:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b>: daily</description></item>
        /// <item><description><b>month</b>: monthly</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("StatisticsType")]
        [Validation(Required=false)]
        public string StatisticsType { get; set; }

    }

}
