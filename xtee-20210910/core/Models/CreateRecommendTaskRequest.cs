// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateRecommendTaskRequest : TeaModel {
        /// <summary>
        /// <para>Set the language type for requests and received messages, default value is <b>zh</b>. Values:</para>
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
        /// <para>Name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>注册样本</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>Task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5467</para>
        /// </summary>
        [NameInMap("sampleId")]
        [Validation(Required=false)]
        public long? SampleId { get; set; }

        /// <summary>
        /// <para>Variables to be calculated, variables</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;1112\&quot;,\&quot;1113\&quot;]</para>
        /// </summary>
        [NameInMap("variablesStr")]
        [Validation(Required=false)]
        public string VariablesStr { get; set; }

        /// <summary>
        /// <para>Indicator effect</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;dxkkLw8fe18\&quot;,\&quot;dxUxSCM26d7\&quot;]</para>
        /// </summary>
        [NameInMap("velocitiesStr")]
        [Validation(Required=false)]
        public string VelocitiesStr { get; set; }

    }

}
