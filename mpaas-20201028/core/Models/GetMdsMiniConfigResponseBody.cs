// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class GetMdsMiniConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public GetMdsMiniConfigResponseBodyResultContent ResultContent { get; set; }
        public class GetMdsMiniConfigResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetMdsMiniConfigResponseBodyResultContentData Data { get; set; }
            public class GetMdsMiniConfigResponseBodyResultContentData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public GetMdsMiniConfigResponseBodyResultContentDataContent Content { get; set; }
                public class GetMdsMiniConfigResponseBodyResultContentDataContent : TeaModel {
                    [NameInMap("ApiConfigList")]
                    [Validation(Required=false)]
                    public List<GetMdsMiniConfigResponseBodyResultContentDataContentApiConfigList> ApiConfigList { get; set; }
                    public class GetMdsMiniConfigResponseBodyResultContentDataContentApiConfigList : TeaModel {
                        [NameInMap("AppCode")]
                        [Validation(Required=false)]
                        public string AppCode { get; set; }

                        [NameInMap("ConfigStatus")]
                        [Validation(Required=false)]
                        public long? ConfigStatus { get; set; }

                        [NameInMap("ConfigType")]
                        [Validation(Required=false)]
                        public string ConfigType { get; set; }

                        [NameInMap("ConfigValue")]
                        [Validation(Required=false)]
                        public string ConfigValue { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("H5Id")]
                        [Validation(Required=false)]
                        public string H5Id { get; set; }

                        [NameInMap("H5Name")]
                        [Validation(Required=false)]
                        public string H5Name { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                    }

                    [NameInMap("AppCode")]
                    [Validation(Required=false)]
                    public string AppCode { get; set; }

                    [NameInMap("EnableServerDomainCount")]
                    [Validation(Required=false)]
                    public string EnableServerDomainCount { get; set; }

                    [NameInMap("H5Id")]
                    [Validation(Required=false)]
                    public string H5Id { get; set; }

                    [NameInMap("H5Name")]
                    [Validation(Required=false)]
                    public string H5Name { get; set; }

                    [NameInMap("PrivilegeSwitch")]
                    [Validation(Required=false)]
                    public GetMdsMiniConfigResponseBodyResultContentDataContentPrivilegeSwitch PrivilegeSwitch { get; set; }
                    public class GetMdsMiniConfigResponseBodyResultContentDataContentPrivilegeSwitch : TeaModel {
                        [NameInMap("AppCode")]
                        [Validation(Required=false)]
                        public string AppCode { get; set; }

                        [NameInMap("ConfigStatus")]
                        [Validation(Required=false)]
                        public long? ConfigStatus { get; set; }

                        [NameInMap("ConfigType")]
                        [Validation(Required=false)]
                        public string ConfigType { get; set; }

                        [NameInMap("ConfigValue")]
                        [Validation(Required=false)]
                        public string ConfigValue { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("H5Id")]
                        [Validation(Required=false)]
                        public string H5Id { get; set; }

                        [NameInMap("H5Name")]
                        [Validation(Required=false)]
                        public string H5Name { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                    }

                    [NameInMap("ServerDomainConfigList")]
                    [Validation(Required=false)]
                    public List<GetMdsMiniConfigResponseBodyResultContentDataContentServerDomainConfigList> ServerDomainConfigList { get; set; }
                    public class GetMdsMiniConfigResponseBodyResultContentDataContentServerDomainConfigList : TeaModel {
                        [NameInMap("AppCode")]
                        [Validation(Required=false)]
                        public string AppCode { get; set; }

                        [NameInMap("ConfigStatus")]
                        [Validation(Required=false)]
                        public long? ConfigStatus { get; set; }

                        [NameInMap("ConfigType")]
                        [Validation(Required=false)]
                        public string ConfigType { get; set; }

                        [NameInMap("ConfigValue")]
                        [Validation(Required=false)]
                        public string ConfigValue { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("H5Id")]
                        [Validation(Required=false)]
                        public string H5Id { get; set; }

                        [NameInMap("H5Name")]
                        [Validation(Required=false)]
                        public string H5Name { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                    }

                    [NameInMap("WebviewDomainConfigList")]
                    [Validation(Required=false)]
                    public List<GetMdsMiniConfigResponseBodyResultContentDataContentWebviewDomainConfigList> WebviewDomainConfigList { get; set; }
                    public class GetMdsMiniConfigResponseBodyResultContentDataContentWebviewDomainConfigList : TeaModel {
                        [NameInMap("AppCode")]
                        [Validation(Required=false)]
                        public string AppCode { get; set; }

                        [NameInMap("ConfigStatus")]
                        [Validation(Required=false)]
                        public long? ConfigStatus { get; set; }

                        [NameInMap("ConfigType")]
                        [Validation(Required=false)]
                        public string ConfigType { get; set; }

                        [NameInMap("ConfigValue")]
                        [Validation(Required=false)]
                        public string ConfigValue { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("H5Id")]
                        [Validation(Required=false)]
                        public string H5Id { get; set; }

                        [NameInMap("H5Name")]
                        [Validation(Required=false)]
                        public string H5Name { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                    }

                }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
