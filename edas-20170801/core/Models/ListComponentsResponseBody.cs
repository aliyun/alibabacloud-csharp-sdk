// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListComponentsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The components.
        /// </summary>
        [NameInMap("ComponentList")]
        [Validation(Required=false)]
        public ListComponentsResponseBodyComponentList ComponentList { get; set; }
        public class ListComponentsResponseBodyComponentList : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=false)]
            public List<ListComponentsResponseBodyComponentListComponent> Component { get; set; }
            public class ListComponentsResponseBodyComponentListComponent : TeaModel {
                /// <summary>
                /// The ID of the component.
                /// </summary>
                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                /// <summary>
                /// The key of the component.
                /// </summary>
                [NameInMap("ComponentKey")]
                [Validation(Required=false)]
                public string ComponentKey { get; set; }

                /// <summary>
                /// The description of the component.
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// Indicates whether the component has expired. Valid values:
                /// 
                /// *   false: The component has not expired.
                /// *   true: The component has expired.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// The type of the component. Valid values:
                /// 
                /// *   JDK
                /// *   TOMCAT
                /// *   TENGINE
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The version of the component.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
