// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionCurrentVersionRequest : TeaModel {
        /// <summary>
        /// <para>The category. By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>general</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The industry. By default, this parameter is left empty, which indicates General-purpose Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecommerce</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The type of the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAAS. This is the default value.</description></item>
        /// <item><description>SAAS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAAS</para>
        /// </summary>
        [NameInMap("functionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// <para>The type of the model. The following features correspond to different model types:</para>
        /// <list type="bullet">
        /// <item><description>CTR model: tf_checkpoint</description></item>
        /// <item><description>Popularity model: pop</description></item>
        /// <item><description>Category model: offline_inference</description></item>
        /// <item><description>Hotword model: offline_inference</description></item>
        /// <item><description>Shading model: offline_inference</description></item>
        /// <item><description>Drop-down suggestion model: offline_inference</description></item>
        /// <item><description>Word segmentation model: text</description></item>
        /// <item><description>Word weight model: tf_checkpoint</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tf_checkpoint</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

    }

}
