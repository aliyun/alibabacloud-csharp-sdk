// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class BatchCreateEtlMetaRequest : TeaModel {
        [NameInMap("etlMetaList")]
        [Validation(Required=false)]
        public List<BatchCreateEtlMetaRequestEtlMetaList> EtlMetaList { get; set; }
        public class BatchCreateEtlMetaRequestEtlMetaList : TeaModel {
            /// <summary>
            /// 是否启用
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// key。由 ascii 可打印字符组成，包括数字、英文大小写字母、下划线、连字符、英文标点符号等组成，长度在[1,255]之间。
            /// </summary>
            [NameInMap("etlMetaKey")]
            [Validation(Required=false)]
            public string EtlMetaKey { get; set; }

            /// <summary>
            /// 名字。由数字、大小写字母、下划线_、连字符-组成，长度需要在[2,64]之间。
            /// </summary>
            [NameInMap("etlMetaName")]
            [Validation(Required=false)]
            public string EtlMetaName { get; set; }

            /// <summary>
            /// key。由 ascii 可打印字符组成，包括数字、英文大小写字母、下划线、连字符、英文标点符号等组成，长度在[1,128]之间。
            /// </summary>
            [NameInMap("etlMetaTag")]
            [Validation(Required=false)]
            public string EtlMetaTag { get; set; }

            [NameInMap("etlMetaValue")]
            [Validation(Required=false)]
            public Dictionary<string, object> EtlMetaValue { get; set; }

        }

    }

}
