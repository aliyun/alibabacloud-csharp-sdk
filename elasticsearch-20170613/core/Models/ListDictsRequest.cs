// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDictsRequest : TeaModel {
        /// <summary>
        /// <para>The dictionary type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IK: IK cold update dictionary.</para>
        /// </description></item>
        /// <item><description><para>IK_HOT: IK hot update dictionary.</para>
        /// </description></item>
        /// <item><description><para>SYNONYMS: Synonym dictionary.</para>
        /// </description></item>
        /// <item><description><para>ALIWS: Alibaba dictionary.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IK</para>
        /// </summary>
        [NameInMap("analyzerType")]
        [Validation(Required=false)]
        public string AnalyzerType { get; set; }

        /// <summary>
        /// <para>The name of the file to filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_MAIN.dic</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
