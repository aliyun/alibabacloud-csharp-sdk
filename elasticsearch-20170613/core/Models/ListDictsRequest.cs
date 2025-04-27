// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDictsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the dictionary. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IK: IK dictionary after a standard update</description></item>
        /// <item><description>IK_HOT: IK dictionary after a rolling update</description></item>
        /// <item><description>SYNONYMS: synonym dictionary</description></item>
        /// <item><description>ALIWS: Alibaba Cloud dictionary</description></item>
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
        /// <para>The name of the dictionary file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_MAIN.dic</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
