// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateFunctionInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The parameters used to create the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[   { &quot;name&quot;: &quot;param1&quot;, &quot;value&quot;: &quot;val1&quot;   } ]</para>
        /// </summary>
        [NameInMap("createParameters")]
        [Validation(Required=false)]
        public List<CreateFunctionInstanceRequestCreateParameters> CreateParameters { get; set; }
        public class CreateFunctionInstanceRequestCreateParameters : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>title_field</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>title</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The CRON expression used to schedule periodic training, in the format of Minutes Hours DayofMonth Month DayofWeek. The default value is empty, which specifies that no periodic training is performed. A value of 0 for DayofWeek specifies Sunday.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 ? * 0,1,2,3,4,5,6</para>
        /// </summary>
        [NameInMap("cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test instance</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The feature type.</para>
        /// <list type="bullet">
        /// <item><description>Default value: PAAS. Training is required before you can use the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAAS</para>
        /// </summary>
        [NameInMap("functionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 1 to 30 characters in length and can contain letters, digits, and underscores (_). The name is case-sensitive and must start with a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ctr_test</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The model type. The value varies based on the model.</para>
        /// <list type="bullet">
        /// <item><description>Click-through rate (CTR) model: tf_checkpoint</description></item>
        /// <item><description>Popularity model: pop</description></item>
        /// <item><description>Category model: offline_inference</description></item>
        /// <item><description>Hotword model: offline_inference</description></item>
        /// <item><description>Hint model: offline_inference</description></item>
        /// <item><description>Hotword model for real-time top searches: near_realtime</description></item>
        /// <item><description>Personalized hint model: near_realtime</description></item>
        /// <item><description>Drop-down suggestion model: offline_inference</description></item>
        /// <item><description>Tokenization model: text</description></item>
        /// <item><description>Term weight model: tf_checkpoint</description></item>
        /// <item><description>Synonym model: offline_inference</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tf_checkpoint</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The parameters used to use the instance.</para>
        /// </summary>
        [NameInMap("usageParameters")]
        [Validation(Required=false)]
        public List<CreateFunctionInstanceRequestUsageParameters> UsageParameters { get; set; }
        public class CreateFunctionInstanceRequestUsageParameters : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>allow_dict_id</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
