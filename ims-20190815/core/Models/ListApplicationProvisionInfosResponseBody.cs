// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListApplicationProvisionInfosResponseBody : TeaModel {
        [NameInMap("ApplicationProvisionInfos")]
        [Validation(Required=false)]
        public ListApplicationProvisionInfosResponseBodyApplicationProvisionInfos ApplicationProvisionInfos { get; set; }
        public class ListApplicationProvisionInfosResponseBodyApplicationProvisionInfos : TeaModel {
            [NameInMap("ApplicationProvisionInfo")]
            [Validation(Required=false)]
            public List<ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfo> ApplicationProvisionInfo { get; set; }
            public class ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfo : TeaModel {
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("DelegatedScope")]
                [Validation(Required=false)]
                public ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScope DelegatedScope { get; set; }
                public class ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScope : TeaModel {
                    [NameInMap("PredefinedScopes")]
                    [Validation(Required=false)]
                    public ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                    public class ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScopePredefinedScopes : TeaModel {
                        [NameInMap("PredefinedScope")]
                        [Validation(Required=false)]
                        public List<ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                        public class ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E403EBFD-C997-489D-BFC7-37C05E66D67C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
