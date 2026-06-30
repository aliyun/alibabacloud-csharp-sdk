// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateTicketRequest : TeaModel {
        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public string CustomFields { get; set; }

        [NameInMap("Notify")]
        [Validation(Required=false)]
        public CreateTicketRequestNotify Notify { get; set; }
        public class CreateTicketRequestNotify : TeaModel {
            [NameInMap("GroupNoticeReceiverUserIds")]
            [Validation(Required=false)]
            public List<string> GroupNoticeReceiverUserIds { get; set; }

            [NameInMap("NoticeAllGroupMember")]
            [Validation(Required=false)]
            public bool? NoticeAllGroupMember { get; set; }

            [NameInMap("WorkNoticeReceiverUserIds")]
            [Validation(Required=false)]
            public List<string> WorkNoticeReceiverUserIds { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OpenTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OpenTemplateBizId")]
        [Validation(Required=false)]
        public string OpenTemplateBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProcessorUserIds")]
        [Validation(Required=false)]
        public List<string> ProcessorUserIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("SceneContext")]
        [Validation(Required=false)]
        public CreateTicketRequestSceneContext SceneContext { get; set; }
        public class CreateTicketRequestSceneContext : TeaModel {
            [NameInMap("GroupMsgs")]
            [Validation(Required=false)]
            public List<CreateTicketRequestSceneContextGroupMsgs> GroupMsgs { get; set; }
            public class CreateTicketRequestSceneContextGroupMsgs : TeaModel {
                [NameInMap("Anchor")]
                [Validation(Required=false)]
                public bool? Anchor { get; set; }

                [NameInMap("OpenMsgId")]
                [Validation(Required=false)]
                public string OpenMsgId { get; set; }

            }

            [NameInMap("OpenConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            [NameInMap("RelevantorUserIds")]
            [Validation(Required=false)]
            public List<string> RelevantorUserIds { get; set; }

            [NameInMap("TopicId")]
            [Validation(Required=false)]
            public string TopicId { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateTicketRequestTenantContext TenantContext { get; set; }
        public class CreateTicketRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
