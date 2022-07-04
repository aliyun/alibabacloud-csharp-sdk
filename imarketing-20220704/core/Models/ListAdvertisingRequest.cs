// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class ListAdvertisingRequest : TeaModel {
        /// <summary>
        /// app
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public ListAdvertisingRequestApp App { get; set; }
        public class ListAdvertisingRequestApp : TeaModel {
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public Dictionary<string, string> Ext { get; set; }
            [NameInMap("Mediaid")]
            [Validation(Required=false)]
            public string Mediaid { get; set; }
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }
        };

        [NameInMap("Dealtype")]
        [Validation(Required=false)]
        public int? Dealtype { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, object> Ext { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// imp
        /// </summary>
        [NameInMap("Imp")]
        [Validation(Required=false)]
        public List<ListAdvertisingRequestImp> Imp { get; set; }
        public class ListAdvertisingRequestImp : TeaModel {
            /// <summary>
            /// id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// tagid
            /// </summary>
            [NameInMap("Tagid")]
            [Validation(Required=false)]
            public string Tagid { get; set; }

        }

        /// <summary>
        /// test
        /// </summary>
        [NameInMap("Test")]
        [Validation(Required=false)]
        public int? Test { get; set; }

        /// <summary>
        /// user
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public ListAdvertisingRequestUser User { get; set; }
        public class ListAdvertisingRequestUser : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Usertype")]
            [Validation(Required=false)]
            public string Usertype { get; set; }
        };

    }

}
