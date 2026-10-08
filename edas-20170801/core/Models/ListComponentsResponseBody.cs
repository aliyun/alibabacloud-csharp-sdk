// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListComponentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ComponentList")]
        [Validation(Required=false)]
        public ListComponentsResponseBodyComponentList ComponentList { get; set; }
        public class ListComponentsResponseBodyComponentList : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=false)]
            public List<ListComponentsResponseBodyComponentListComponent> Component { get; set; }
            public class ListComponentsResponseBodyComponentListComponent : TeaModel {
                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                [NameInMap("ComponentKey")]
                [Validation(Required=false)]
                public string ComponentKey { get; set; }

                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
