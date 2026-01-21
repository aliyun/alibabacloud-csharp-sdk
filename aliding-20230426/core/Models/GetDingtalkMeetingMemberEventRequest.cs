// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetDingtalkMeetingMemberEventRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetDingtalkMeetingMemberEventRequestTenantContext TenantContext { get; set; }
        public class GetDingtalkMeetingMemberEventRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1638360000000</para>
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61289fxxx</para>
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1638363600000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21001</para>
        /// </summary>
        [NameInMap("orgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>34242</para>
        /// </summary>
        [NameInMap("workNo")]
        [Validation(Required=false)]
        public string WorkNo { get; set; }

    }

}
