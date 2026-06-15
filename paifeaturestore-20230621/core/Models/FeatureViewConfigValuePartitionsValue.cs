// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class FeatureViewConfigValuePartitionsValue : TeaModel {
        /// <summary>
        /// <para>Partition value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230101</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>List of partitions.</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// <para>Start time partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230101</para>
        /// </summary>
        [NameInMap("StartValue")]
        [Validation(Required=false)]
        public string StartValue { get; set; }

        /// <summary>
        /// <para>End time partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230202</para>
        /// </summary>
        [NameInMap("EndValue")]
        [Validation(Required=false)]
        public string EndValue { get; set; }

    }

}
