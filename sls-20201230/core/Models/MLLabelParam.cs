// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MLLabelParam : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1695090077</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>默认表</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abbd488f6dd42d294495fb780858e83d</para>
        /// </summary>
        [NameInMap("labelId")]
        [Validation(Required=false)]
        public string LabelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1695090077</para>
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>标签表</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("settings")]
        [Validation(Required=false)]
        public List<MLLabelParamSettings> Settings { get; set; }
        public class MLLabelParamSettings : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>builtin</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Trace.RCA</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
