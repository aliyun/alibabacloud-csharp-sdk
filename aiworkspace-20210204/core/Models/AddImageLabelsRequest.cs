// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class AddImageLabelsRequest : TeaModel {
        /// <summary>
        /// <para>A list of image labels.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<AddImageLabelsRequestLabels> Labels { get; set; }
        public class AddImageLabelsRequestLabels : TeaModel {
            /// <summary>
            /// <para>The key of the label. The following keys are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>system.chipType</para>
            /// </description></item>
            /// <item><description><para>system.dsw\.cudaVersion</para>
            /// </description></item>
            /// <item><description><para>system.dsw\.fromImageId</para>
            /// </description></item>
            /// <item><description><para>system.dsw\.fromInstanceId</para>
            /// </description></item>
            /// <item><description><para>system.dsw\.id</para>
            /// </description></item>
            /// <item><description><para>system.dsw\.os</para>
            /// </description></item>
            /// <item><description><para>system.dsw\.osVersion</para>
            /// </description></item>
            /// <item><description><para>system.dsw\.resourceType</para>
            /// </description></item>
            /// <item><description><para>system.dsw\.rootImageId</para>
            /// </description></item>
            /// <item><description><para>system.dsw\.stage</para>
            /// </description></item>
            /// <item><description><para>system.dsw\.tag</para>
            /// </description></item>
            /// <item><description><para>system.dsw\.type</para>
            /// </description></item>
            /// <item><description><para>system.framework</para>
            /// </description></item>
            /// <item><description><para>system.origin</para>
            /// </description></item>
            /// <item><description><para>system.pythonVersion</para>
            /// </description></item>
            /// <item><description><para>system.source</para>
            /// </description></item>
            /// <item><description><para>system.supported.dlc</para>
            /// </description></item>
            /// <item><description><para>system.supported.dsw</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system.chipType</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the label.</para>
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
