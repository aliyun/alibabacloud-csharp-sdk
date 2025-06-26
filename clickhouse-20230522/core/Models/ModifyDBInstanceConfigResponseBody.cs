// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyDBInstanceConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyDBInstanceConfigResponseBodyData Data { get; set; }
        public class ModifyDBInstanceConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cc-uf6lkzf*****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>05321590-BB65-4720-8C***********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
