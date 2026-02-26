// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Spec : TeaModel {
        /// <summary>
        /// <para>The custom parameters for model training.</para>
        /// </summary>
        [NameInMap("Backbone")]
        [Validation(Required=false)]
        public CustomParams Backbone { get; set; }

        /// <summary>
        /// <para>The number of output classes of the last layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ClassNum")]
        [Validation(Required=false)]
        public long? ClassNum { get; set; }

        /// <summary>
        /// <para>The custom parameters for model training.</para>
        /// </summary>
        [NameInMap("Head")]
        [Validation(Required=false)]
        public CustomParams Head { get; set; }

        /// <summary>
        /// <para>3</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("InputChannel")]
        [Validation(Required=false)]
        public long? InputChannel { get; set; }

        /// <summary>
        /// <para>The custom parameters for model training.</para>
        /// </summary>
        [NameInMap("Loss")]
        [Validation(Required=false)]
        public CustomParams Loss { get; set; }

        /// <summary>
        /// <para>The name of the model. The available model names vary with the model category.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClsResNet</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The custom parameters for model training.</para>
        /// </summary>
        [NameInMap("Neck")]
        [Validation(Required=false)]
        public CustomParams Neck { get; set; }

        /// <summary>
        /// <para>The number of face landmarks. This parameter is required for face detection. In most cases, you can set the parameter to 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("NumLandmarks")]
        [Validation(Required=false)]
        public long? NumLandmarks { get; set; }

        /// <summary>
        /// <para>The path to the pretrained model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/abc/xxx.json</para>
        /// </summary>
        [NameInMap("PretrainedPath")]
        [Validation(Required=false)]
        public string PretrainedPath { get; set; }

    }

}
