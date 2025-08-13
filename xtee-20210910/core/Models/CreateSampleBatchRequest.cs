// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateSampleBatchRequest : TeaModel {
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
        /// <para>Sample batch name</para>
        /// 
        /// <b>Example:</b>
        /// <para>白样本</para>
        /// </summary>
        [NameInMap("batchName")]
        [Validation(Required=false)]
        public string BatchName { get; set; }

        /// <summary>
        /// <para>Data type</para>
        /// 
        /// <b>Example:</b>
        /// <para>mobile</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Content of the list entered in the text box</para>
        /// 
        /// <b>Example:</b>
        /// <para>1770000000,1770000001</para>
        /// </summary>
        [NameInMap("dataValue")]
        [Validation(Required=false)]
        public string DataValue { get; set; }

        /// <summary>
        /// <para>Description information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Uploaded OSS address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample/94b4193d321c44b44ee92b19984000a0/样本测试01/0d8dbc6809834d51b1d88a42295c803e/1753865835166.csv</para>
        /// </summary>
        [NameInMap("ossFileName")]
        [Validation(Required=false)]
        public string OssFileName { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Specific type of sample list</para>
        /// 
        /// <b>Example:</b>
        /// <para>白名单</para>
        /// </summary>
        [NameInMap("sampleBatchType")]
        [Validation(Required=false)]
        public string SampleBatchType { get; set; }

        /// <summary>
        /// <para>Service list</para>
        /// 
        /// <b>Example:</b>
        /// <para>account_takeover</para>
        /// </summary>
        [NameInMap("serviceList")]
        [Validation(Required=false)]
        public string ServiceList { get; set; }

    }

}
