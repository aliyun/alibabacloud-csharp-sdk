// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetModuleConfigStatusResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetModuleConfigStatusResponseBodyData Data { get; set; }
        public class GetModuleConfigStatusResponseBodyData : TeaModel {
            [NameInMap("ModuleConfigResults")]
            [Validation(Required=false)]
            public List<GetModuleConfigStatusResponseBodyDataModuleConfigResults> ModuleConfigResults { get; set; }
            public class GetModuleConfigStatusResponseBodyDataModuleConfigResults : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Ransom</para>
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Pass")]
                [Validation(Required=false)]
                public bool? Pass { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>843E4805-****-7EE12FA8DBFD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
