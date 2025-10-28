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

        /// <summary>
        /// <para>The components.</para>
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
                /// <para>The ID of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                /// <summary>
                /// <para>The key of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JDK 7</para>
                /// </summary>
                [NameInMap("ComponentKey")]
                [Validation(Required=false)]
                public string ComponentKey { get; set; }

                /// <summary>
                /// <para>The description of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JDK 7</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>Indicates whether the component has expired. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: The component has not expired.</description></item>
                /// <item><description>true: The component has expired.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// <para>The type of the component. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>JDK</description></item>
                /// <item><description>TOMCAT</description></item>
                /// <item><description>TENGINE</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>JDK</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oraclejdk7</para>
                /// </summary>
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
