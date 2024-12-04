// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MLDataParam : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dc74b0f569126bb310e1ba6454c351ac</para>
        /// </summary>
        [NameInMap("annotationdataId")]
        [Validation(Required=false)]
        public string AnnotationdataId { get; set; }

        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, MLDataParamAnnotationsValue> Annotations { get; set; }

        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, string> Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1695094335</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>59db060bd89468245d76416a68a510ac</para>
        /// </summary>
        [NameInMap("dataHash")]
        [Validation(Required=false)]
        public string DataHash { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a9bd488f6dd42d294495fb780858e83d</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1695094335</para>
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        [NameInMap("predictions")]
        [Validation(Required=false)]
        public Dictionary<string, MLDataParamPredictionsValue> Predictions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx/xxx/xxx/</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("valueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

    }

}
