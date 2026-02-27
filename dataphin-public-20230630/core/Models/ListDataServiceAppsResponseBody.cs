// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServiceAppsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataServiceAppsResponseBodyData Data { get; set; }
        public class ListDataServiceAppsResponseBodyData : TeaModel {
            [NameInMap("AppList")]
            [Validation(Required=false)]
            public List<ListDataServiceAppsResponseBodyDataAppList> AppList { get; set; }
            public class ListDataServiceAppsResponseBodyDataAppList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>默认分组</para>
                /// </summary>
                [NameInMap("AppGroup")]
                [Validation(Required=false)]
                public string AppGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public int? AppId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>默认应用</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("IsMember")]
                [Validation(Required=false)]
                public bool? IsMember { get; set; }

                [NameInMap("OwnerList")]
                [Validation(Required=false)]
                public List<ListDataServiceAppsResponseBodyDataAppListOwnerList> OwnerList { get; set; }
                public class ListDataServiceAppsResponseBodyDataAppListOwnerList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
