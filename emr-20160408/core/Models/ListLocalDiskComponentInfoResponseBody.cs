// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListLocalDiskComponentInfoResponseBody : TeaModel {
        [NameInMap("ComponentInfoList")]
        [Validation(Required=false)]
        public ListLocalDiskComponentInfoResponseBodyComponentInfoList ComponentInfoList { get; set; }
        public class ListLocalDiskComponentInfoResponseBodyComponentInfoList : TeaModel {
            [NameInMap("ComponentInfo")]
            [Validation(Required=false)]
            public List<ListLocalDiskComponentInfoResponseBodyComponentInfoListComponentInfo> ComponentInfo { get; set; }
            public class ListLocalDiskComponentInfoResponseBodyComponentInfoListComponentInfo : TeaModel {
                public ListLocalDiskComponentInfoResponseBodyComponentInfoListComponentInfoApmMetrics ApmMetrics { get; set; }
                public class ListLocalDiskComponentInfoResponseBodyComponentInfoListComponentInfoApmMetrics : TeaModel {
                    [NameInMap("ApmMetric")]
                    [Validation(Required=false)]
                    public List<string> ApmMetric { get; set; }

                }
                public string ComponentDisplayName { get; set; }
                public string ComponentName { get; set; }
                public string IsolateWarningMsg { get; set; }
                public ListLocalDiskComponentInfoResponseBodyComponentInfoListComponentInfoMountParams MountParams { get; set; }
                public class ListLocalDiskComponentInfoResponseBodyComponentInfoListComponentInfoMountParams : TeaModel {
                    [NameInMap("MountParam")]
                    [Validation(Required=false)]
                    public List<ListLocalDiskComponentInfoResponseBodyComponentInfoListComponentInfoMountParamsMountParam> MountParam { get; set; }
                    public class ListLocalDiskComponentInfoResponseBodyComponentInfoListComponentInfoMountParamsMountParam : TeaModel {
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Max")]
                        [Validation(Required=false)]
                        public int? Max { get; set; }

                        [NameInMap("Min")]
                        [Validation(Required=false)]
                        public int? Min { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Options")]
                        [Validation(Required=false)]
                        public ListLocalDiskComponentInfoResponseBodyComponentInfoListComponentInfoMountParamsMountParamOptions Options { get; set; }
                        public class ListLocalDiskComponentInfoResponseBodyComponentInfoListComponentInfoMountParamsMountParamOptions : TeaModel {
                            [NameInMap("Option")]
                            [Validation(Required=false)]
                            public List<string> Option { get; set; }
                        };

                        [NameInMap("Tips")]
                        [Validation(Required=false)]
                        public string Tips { get; set; }

                        [NameInMap("Unit")]
                        [Validation(Required=false)]
                        public string Unit { get; set; }

                        [NameInMap("ValueType")]
                        [Validation(Required=false)]
                        public string ValueType { get; set; }

                    }

                }
                public string MountWarningMsg { get; set; }
                public string RebootWarningMsg { get; set; }
                public string ServiceDisplayName { get; set; }
                public string ServiceName { get; set; }
                public bool? SupportDiskHotSwap { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
