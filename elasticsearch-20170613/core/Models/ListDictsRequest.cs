// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDictsRequest : TeaModel {
        /// <summary>
        /// The type of the dictionary. Valid values:
        /// 
        /// *   IK: IK dictionary after a standard update
        /// *   IK_HOT: IK dictionary after a rolling update
        /// *   SYNONYMS: synonym dictionary
        /// *   ALIWS: Alibaba Cloud dictionary
        /// </summary>
        [NameInMap("analyzerType")]
        [Validation(Required=false)]
        public string AnalyzerType { get; set; }

        /// <summary>
        /// The name of the dictionary file.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
