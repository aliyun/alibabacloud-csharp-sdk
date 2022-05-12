// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class SearchAdvertisingRequest : TeaModel {
        /// <summary>
        /// app
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public SearchAdvertisingRequestApp App { get; set; }
        public class SearchAdvertisingRequestApp : TeaModel {
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
        public List<SearchAdvertisingRequestImp> Imp { get; set; }
        public class SearchAdvertisingRequestImp : TeaModel {
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
        public SearchAdvertisingRequestUser User { get; set; }
        public class SearchAdvertisingRequestUser : TeaModel {
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }
            [NameInMap("Uidtype")]
            [Validation(Required=false)]
            public string Uidtype { get; set; }
        };

    }

}
