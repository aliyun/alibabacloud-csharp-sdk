// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class ListSpecificAdRequest : TeaModel {
        /// <summary>
        /// app
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public ListSpecificAdRequestApp App { get; set; }
        public class ListSpecificAdRequestApp : TeaModel {
            /// <summary>
            /// ext
            /// </summary>
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public Dictionary<string, object> Ext { get; set; }

            /// <summary>
            /// mediaid
            /// </summary>
            [NameInMap("Mediaid")]
            [Validation(Required=false)]
            public string Mediaid { get; set; }

            /// <summary>
            /// sn
            /// </summary>
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

        }

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
        public List<ListSpecificAdRequestImp> Imp { get; set; }
        public class ListSpecificAdRequestImp : TeaModel {
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
        /// user
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public ListSpecificAdRequestUser User { get; set; }
        public class ListSpecificAdRequestUser : TeaModel {
            /// <summary>
            /// uid
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// uidtype
            /// </summary>
            [NameInMap("Usertype")]
            [Validation(Required=false)]
            public string Usertype { get; set; }

        }

        [NameInMap("Verifyad")]
        [Validation(Required=false)]
        public List<ListSpecificAdRequestVerifyad> Verifyad { get; set; }
        public class ListSpecificAdRequestVerifyad : TeaModel {
            /// <summary>
            /// id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Itemid")]
            [Validation(Required=false)]
            public string Itemid { get; set; }

            [NameInMap("Marketingtype")]
            [Validation(Required=false)]
            public string Marketingtype { get; set; }

            [NameInMap("Seat")]
            [Validation(Required=false)]
            public string Seat { get; set; }

        }

    }

}
