// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateSampleApiRequest : TeaModel {
        /// <summary>
        /// <para>Same as the request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip/accountID</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The specific data value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>同参数</para>
        /// </summary>
        [NameInMap("DataValue")]
        [Validation(Required=false)]
        public string DataValue { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The sample batch type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>白名单/黑名单/混合</para>
        /// </summary>
        [NameInMap("SampleBatchType")]
        [Validation(Required=false)]
        public string SampleBatchType { get; set; }

        /// <summary>
        /// <para>The list of services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>同参数</para>
        /// </summary>
        [NameInMap("ServiceList")]
        [Validation(Required=false)]
        public string ServiceList { get; set; }

    }

}
