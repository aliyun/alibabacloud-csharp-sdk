// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListAuthorityResponseBody : TeaModel {
        /// <summary>
        /// <para>The permissions.</para>
        /// </summary>
        [NameInMap("AuthorityList")]
        [Validation(Required=false)]
        public ListAuthorityResponseBodyAuthorityList AuthorityList { get; set; }
        public class ListAuthorityResponseBodyAuthorityList : TeaModel {
            [NameInMap("Authority")]
            [Validation(Required=false)]
            public List<ListAuthorityResponseBodyAuthorityListAuthority> Authority { get; set; }
            public class ListAuthorityResponseBodyAuthorityListAuthority : TeaModel {
                /// <summary>
                /// <para>The set of permissions.</para>
                /// </summary>
                [NameInMap("ActionList")]
                [Validation(Required=false)]
                public ListAuthorityResponseBodyAuthorityListAuthorityActionList ActionList { get; set; }
                public class ListAuthorityResponseBodyAuthorityListAuthorityActionList : TeaModel {
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public List<ListAuthorityResponseBodyAuthorityListAuthorityActionListAction> Action { get; set; }
                    public class ListAuthorityResponseBodyAuthorityListAuthorityActionListAction : TeaModel {
                        /// <summary>
                        /// <para>The code of the permission.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The description of the permission.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Create an application</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The ID of the permission group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public string GroupId { get; set; }

                        /// <summary>
                        /// <para>The name of the permission.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Create an application</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// <para>The description of the permission group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Operations on applications</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the permission group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the permission group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Application management</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

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
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57609587-DFA2-41EC-<b><b>-</b></b>*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
