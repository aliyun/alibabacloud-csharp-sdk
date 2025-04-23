// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class AddImageLabelsRequest : TeaModel {
        /// <summary>
        /// <para>The list of image tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<AddImageLabelsRequestLabels> Labels { get; set; }
        public class AddImageLabelsRequestLabels : TeaModel {
            /// <summary>
            /// <para>The tag key. The following keys can be added:</para>
            /// <list type="bullet">
            /// <item><description>system.chipType</description></item>
            /// <item><description>system.dsw.cudaVersion</description></item>
            /// <item><description>system.dsw.fromImageId</description></item>
            /// <item><description>system.dsw.fromInstanceId</description></item>
            /// <item><description>system.dsw.id</description></item>
            /// <item><description>system.dsw.os</description></item>
            /// <item><description>system.dsw.osVersion</description></item>
            /// <item><description>system.dsw.resourceType</description></item>
            /// <item><description>system.dsw.rootImageId</description></item>
            /// <item><description>system.dsw.stage</description></item>
            /// <item><description>system.dsw.tag</description></item>
            /// <item><description>system.dsw.type</description></item>
            /// <item><description>system.framework</description></item>
            /// <item><description>system.origin</description></item>
            /// <item><description>system.pythonVersion</description></item>
            /// <item><description>system.source</description></item>
            /// <item><description>system.supported.dlc</description></item>
            /// <item><description>system.supported.dsw</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system.chipType</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GPU</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
