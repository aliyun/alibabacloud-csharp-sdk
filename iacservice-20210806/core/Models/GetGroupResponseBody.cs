// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetGroupResponseBody : TeaModel {
        [NameInMap("group")]
        [Validation(Required=false)]
        public GetGroupResponseBodyGroup Group { get; set; }
        public class GetGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoDestroy")]
            [Validation(Required=false)]
            public bool? AutoDestroy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoTrigger")]
            [Validation(Required=false)]
            public bool? AutoTrigger { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-21T10:57:11Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("forcedSetting")]
            [Validation(Required=false)]
            public bool? ForcedSetting { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>g-14e80de4866bf7ffed0bab6154d738</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("notifyConfig")]
            [Validation(Required=false)]
            public List<GetGroupResponseBodyGroupNotifyConfig> NotifyConfig { get; set; }
            public class GetGroupResponseBodyGroupNotifyConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("notifyPath")]
                [Validation(Required=false)]
                public string NotifyPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DingDing</para>
                /// </summary>
                [NameInMap("notifyType")]
                [Validation(Required=false)]
                public string NotifyType { get; set; }

            }

            [NameInMap("notifyOperationTypes")]
            [Validation(Required=false)]
            public List<string> NotifyOperationTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-4267dcfbf1b6d126edcadf0e949</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ramRoleName</para>
            /// </summary>
            [NameInMap("ramRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            [NameInMap("reportExportField")]
            [Validation(Required=false)]
            public List<string> ReportExportField { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("reportExportPath")]
            [Validation(Required=false)]
            public string ReportExportPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("taskCnt")]
            [Validation(Required=false)]
            public long? TaskCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.191.0</para>
            /// </summary>
            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

            [NameInMap("triggerConfig")]
            [Validation(Required=false)]
            public List<GetGroupResponseBodyGroupTriggerConfig> TriggerConfig { get; set; }
            public class GetGroupResponseBodyGroupTriggerConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Cron</para>
                /// </summary>
                [NameInMap("triggerStrategy")]
                [Validation(Required=false)]
                public string TriggerStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0 0 8 * * ?</para>
                /// </summary>
                [NameInMap("triggerValue")]
                [Validation(Required=false)]
                public string TriggerValue { get; set; }

            }

            [NameInMap("triggerResourceType")]
            [Validation(Required=false)]
            public List<string> TriggerResourceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B6ED9F71-7FA8-598E-B64D-4606FB3FCCC9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
