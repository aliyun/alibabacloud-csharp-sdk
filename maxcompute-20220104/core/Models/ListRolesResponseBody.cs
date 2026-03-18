// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListRolesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListRolesResponseBodyData Data { get; set; }
        public class ListRolesResponseBodyData : TeaModel {
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListRolesResponseBodyDataRoles> Roles { get; set; }
            public class ListRolesResponseBodyDataRoles : TeaModel {
                [NameInMap("acl")]
                [Validation(Required=false)]
                public ListRolesResponseBodyDataRolesAcl Acl { get; set; }
                public class ListRolesResponseBodyDataRolesAcl : TeaModel {
                    [NameInMap("function")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclFunction> Function { get; set; }
                    public class ListRolesResponseBodyDataRolesAclFunction : TeaModel {
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("instance")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclInstance> Instance { get; set; }
                    public class ListRolesResponseBodyDataRolesAclInstance : TeaModel {
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("package")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclPackage> Package { get; set; }
                    public class ListRolesResponseBodyDataRolesAclPackage : TeaModel {
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclProject> Project { get; set; }
                    public class ListRolesResponseBodyDataRolesAclProject : TeaModel {
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("resource")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclResource> Resource { get; set; }
                    public class ListRolesResponseBodyDataRolesAclResource : TeaModel {
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("table")]
                    [Validation(Required=false)]
                    public List<ListRolesResponseBodyDataRolesAclTable> Table { get; set; }
                    public class ListRolesResponseBodyDataRolesAclTable : TeaModel {
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<string> Actions { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
