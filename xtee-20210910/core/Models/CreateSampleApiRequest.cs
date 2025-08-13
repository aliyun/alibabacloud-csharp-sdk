// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateSampleApiRequest : TeaModel {
        /// <summary>
        /// <para>Same as input parameter</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip/accountID</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Specific data value</para>
        /// 
        /// <b>Example:</b>
        /// <para>同参数</para>
        /// </summary>
        [NameInMap("DataValue")]
        [Validation(Required=false)]
        public string DataValue { get; set; }

        /// <summary>
        /// <para>Sets the language type for requests and received messages, with a default value of <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>regionId</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Sample batch type</para>
        /// 
        /// <b>Example:</b>
        /// <para>白名单/黑名单/混合</para>
        /// </summary>
        [NameInMap("SampleBatchType")]
        [Validation(Required=false)]
        public string SampleBatchType { get; set; }

        /// <summary>
        /// <para>Service list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>同参数</para>
        /// </summary>
        [NameInMap("ServiceList")]
        [Validation(Required=false)]
        public string ServiceList { get; set; }

    }

}
