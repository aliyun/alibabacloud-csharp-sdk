// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAccountsResponseBody : TeaModel {
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public ListAccountsResponseBodyAccounts Accounts { get; set; }
        public class ListAccountsResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<ListAccountsResponseBodyAccountsAccount> Account { get; set; }
            public class ListAccountsResponseBodyAccountsAccount : TeaModel {
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                [NameInMap("JoinMethod")]
                [Validation(Required=false)]
                public string JoinMethod { get; set; }

                [NameInMap("JoinTime")]
                [Validation(Required=false)]
                public string JoinTime { get; set; }

                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                [NameInMap("ResourceDirectoryId")]
                [Validation(Required=false)]
                public string ResourceDirectoryId { get; set; }

                [NameInMap("ResourceDirectoryPath")]
                [Validation(Required=false)]
                public string ResourceDirectoryPath { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListAccountsResponseBodyAccountsAccountTags Tags { get; set; }
                public class ListAccountsResponseBodyAccountsAccountTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListAccountsResponseBodyAccountsAccountTagsTag> Tag { get; set; }
                    public class ListAccountsResponseBodyAccountsAccountTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B8A4E7D-6CFF-471D-84DF-195A7A241ECB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
