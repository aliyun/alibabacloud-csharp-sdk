// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class AssignJobsRequest : TeaModel {
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12f3dd08-0c55-44ce-9b64-e69d35ed3a76</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsAsynchrony")]
        [Validation(Required=false)]
        public bool? IsAsynchrony { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d004cfd2-6a81-491c-83c6-cbe186620c95</para>
        /// </summary>
        [NameInMap("JobDataParsingTaskId")]
        [Validation(Required=false)]
        public string JobDataParsingTaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d004cfd2-6a81-491c-83c6-cbe186620c95</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        [NameInMap("JobsJson")]
        [Validation(Required=false)]
        public List<string> JobsJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>json</para>
        /// </summary>
        [NameInMap("RosterType")]
        [Validation(Required=false)]
        public string RosterType { get; set; }

        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

    }

}
