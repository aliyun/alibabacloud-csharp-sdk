// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Spec : TeaModel {
        [NameInMap("Backbone")]
        [Validation(Required=false)]
        public CustomParams Backbone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ClassNum")]
        [Validation(Required=false)]
        public long? ClassNum { get; set; }

        [NameInMap("Head")]
        [Validation(Required=false)]
        public CustomParams Head { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("InputChannel")]
        [Validation(Required=false)]
        public long? InputChannel { get; set; }

        [NameInMap("Loss")]
        [Validation(Required=false)]
        public CustomParams Loss { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClsResNet</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Neck")]
        [Validation(Required=false)]
        public CustomParams Neck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("NumLandmarks")]
        [Validation(Required=false)]
        public long? NumLandmarks { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://bucket/abc/xxx.json</para>
        /// </summary>
        [NameInMap("PretrainedPath")]
        [Validation(Required=false)]
        public string PretrainedPath { get; set; }

    }

}
