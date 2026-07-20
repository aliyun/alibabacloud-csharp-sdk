// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeSuspEventsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-guangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public DescribeSuspEventsRequestSdkRequest SdkRequest { get; set; }
        public class DescribeSuspEventsRequestSdkRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6838133766c37077d0515b0b557e6510</para>
            /// </summary>
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            [NameInMap("AssetsTypeList")]
            [Validation(Required=false)]
            public List<string> AssetsTypeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxljob-02f023138826b</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
            [NameInMap("ContainerFieldName")]
            [Validation(Required=false)]
            public string ContainerFieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ca9b91db58356b41af2932e8048310ab7daa415701fa62d823cf4f0406d5ce02</para>
            /// </summary>
            [NameInMap("ContainerFieldValue")]
            [Validation(Required=false)]
            public string ContainerFieldValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public string CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Dealed")]
            [Validation(Required=false)]
            public string Dealed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("DetectSource")]
            [Validation(Required=false)]
            public string DetectSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WEBSHELL</para>
            /// </summary>
            [NameInMap("EventNames")]
            [Validation(Required=false)]
            public string EventNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sas</para>
            /// </summary>
            [NameInMap("From")]
            [Validation(Required=false)]
            public string From { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18768</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3165</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>serious</para>
            /// </summary>
            [NameInMap("Levels")]
            [Validation(Required=false)]
            public string Levels { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MultiAccountActionType")]
            [Validation(Required=false)]
            public int? MultiAccountActionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs-xxx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OperateErrorCodeList")]
            [Validation(Required=false)]
            public List<string> OperateErrorCodeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-06 13:50:38</para>
            /// </summary>
            [NameInMap("OperateTimeEnd")]
            [Validation(Required=false)]
            public string OperateTimeEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-06 13:50:38</para>
            /// </summary>
            [NameInMap("OperateTimeStart")]
            [Validation(Required=false)]
            public string OperateTimeStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>恶意脚本</para>
            /// </summary>
            [NameInMap("ParentEventTypes")]
            [Validation(Required=false)]
            public string ParentEventTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5815612291408486</para>
            /// </summary>
            [NameInMap("ResourceDirectoryAccountId")]
            [Validation(Required=false)]
            public long? ResourceDirectoryAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lastTime</para>
            /// </summary>
            [NameInMap("SortColumn")]
            [Validation(Required=false)]
            public string SortColumn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>asc</para>
            /// </summary>
            [NameInMap("SortType")]
            [Validation(Required=false)]
            public string SortType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SourceAliUids")]
            [Validation(Required=false)]
            public List<long?> SourceAliUids { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2409:8a55:3827:cb50:5ad9:d5ff:fe87:f48c</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("StrictMode")]
            [Validation(Required=false)]
            public string StrictMode { get; set; }

            [NameInMap("SupportOperateCodeList")]
            [Validation(Required=false)]
            public List<string> SupportOperateCodeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TA0003</para>
            /// </summary>
            [NameInMap("TacticId")]
            [Validation(Required=false)]
            public string TacticId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>containerId</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-06 13:50:38</para>
            /// </summary>
            [NameInMap("TimeEnd")]
            [Validation(Required=false)]
            public string TimeEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-06 13:50:38</para>
            /// </summary>
            [NameInMap("TimeStart")]
            [Validation(Required=false)]
            public string TimeStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f82680d9fdcb74a520fa385b7e9105b7</para>
            /// </summary>
            [NameInMap("UniqueInfo")]
            [Validation(Required=false)]
            public string UniqueInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>inet-eae09bb8-32b1-413b-a8ff-23932e043209</para>
            /// </summary>
            [NameInMap("Uuids")]
            [Validation(Required=false)]
            public string Uuids { get; set; }

        }

    }

}
