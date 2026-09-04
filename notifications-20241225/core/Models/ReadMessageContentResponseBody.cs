// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadMessageContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned when the call fails. For more information, refer to error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The execution result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReadMessageContentResponseBodyData Data { get; set; }
        public class ReadMessageContentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of degradation rules.</para>
            /// </summary>
            [NameInMap("Datas")]
            [Validation(Required=false)]
            public ReadMessageContentResponseBodyDataDatas Datas { get; set; }
            public class ReadMessageContentResponseBodyDataDatas : TeaModel {
                /// <summary>
                /// <para>The data item.</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<ReadMessageContentResponseBodyDataDatasItem> Item { get; set; }
                public class ReadMessageContentResponseBodyDataDatasItem : TeaModel {
                    /// <summary>
                    /// <para>The message category name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>活动消息</para>
                    /// </summary>
                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    /// <summary>
                    /// <para>The message class ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ClassId")]
                    [Validation(Required=false)]
                    public long? ClassId { get; set; }

                    /// <summary>
                    /// <para>The message content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;消息内容示例“</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The deletion flag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public int? Deleted { get; set; }

                    /// <summary>
                    /// <para>The time when the message was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1729758903000</para>
                    /// </summary>
                    [NameInMap("GmtCreated")]
                    [Validation(Required=false)]
                    public long? GmtCreated { get; set; }

                    /// <summary>
                    /// <para>The time when the message was updated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1729758903000</para>
                    /// </summary>
                    [NameInMap("GmtUpdate")]
                    [Validation(Required=false)]
                    public long? GmtUpdate { get; set; }

                    /// <summary>
                    /// <para>A reserved field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/</para>
                    /// </summary>
                    [NameInMap("MassId")]
                    [Validation(Required=false)]
                    public long? MassId { get; set; }

                    /// <summary>
                    /// <para>A reserved field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>385ad715-4139-41f9-ba59-246a00bb46e0.jpg</para>
                    /// </summary>
                    [NameInMap("Memo")]
                    [Validation(Required=false)]
                    public string Memo { get; set; }

                    /// <summary>
                    /// <para>The message ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AC14C11F1FF801EE00054518C220EF2C</para>
                    /// </summary>
                    [NameInMap("MsgId")]
                    [Validation(Required=false)]
                    public long? MsgId { get; set; }

                    /// <summary>
                    /// <para>The read status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: unread</description></item>
                    /// <item><description>1: read.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>not_installed</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    /// <summary>
                    /// <para>The message title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Endless</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>/</para>
                /// </summary>
                [NameInMap("LastItem")]
                [Validation(Required=false)]
                public List<ReadMessageContentResponseBodyDataDatasLastItem> LastItem { get; set; }
                public class ReadMessageContentResponseBodyDataDatasLastItem : TeaModel {
                    /// <summary>
                    /// <para>The message category name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>活动消息</para>
                    /// </summary>
                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    /// <summary>
                    /// <para>The message class ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ClassId")]
                    [Validation(Required=false)]
                    public long? ClassId { get; set; }

                    /// <summary>
                    /// <para>The message content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;消息内容示例“</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The deletion flag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public int? Deleted { get; set; }

                    /// <summary>
                    /// <para>The time when the message was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1729758903000</para>
                    /// </summary>
                    [NameInMap("GmtCreated")]
                    [Validation(Required=false)]
                    public long? GmtCreated { get; set; }

                    /// <summary>
                    /// <para>The time when the message was updated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1729758903000</para>
                    /// </summary>
                    [NameInMap("GmtUpdate")]
                    [Validation(Required=false)]
                    public long? GmtUpdate { get; set; }

                    /// <summary>
                    /// <para>A reserved field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/</para>
                    /// </summary>
                    [NameInMap("MassId")]
                    [Validation(Required=false)]
                    public long? MassId { get; set; }

                    /// <summary>
                    /// <para>A reserved field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/</para>
                    /// </summary>
                    [NameInMap("Memo")]
                    [Validation(Required=false)]
                    public string Memo { get; set; }

                    /// <summary>
                    /// <para>The message ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3727683838</para>
                    /// </summary>
                    [NameInMap("MsgId")]
                    [Validation(Required=false)]
                    public long? MsgId { get; set; }

                    /// <summary>
                    /// <para>The read status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: unread</description></item>
                    /// <item><description>1: read.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    /// <summary>
                    /// <para>The message title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;标题示例“</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>/</para>
                /// </summary>
                [NameInMap("NextItem")]
                [Validation(Required=false)]
                public List<ReadMessageContentResponseBodyDataDatasNextItem> NextItem { get; set; }
                public class ReadMessageContentResponseBodyDataDatasNextItem : TeaModel {
                    /// <summary>
                    /// <para>The message category name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>活动消息</para>
                    /// </summary>
                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    /// <summary>
                    /// <para>The message class ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ClassId")]
                    [Validation(Required=false)]
                    public long? ClassId { get; set; }

                    /// <summary>
                    /// <para>The message content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>”消息内容示例“</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The deletion flag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public int? Deleted { get; set; }

                    /// <summary>
                    /// <para>The time when the message was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1663809374000</para>
                    /// </summary>
                    [NameInMap("GmtCreated")]
                    [Validation(Required=false)]
                    public long? GmtCreated { get; set; }

                    /// <summary>
                    /// <para>The time when the message was updated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1663809374000</para>
                    /// </summary>
                    [NameInMap("GmtUpdate")]
                    [Validation(Required=false)]
                    public long? GmtUpdate { get; set; }

                    /// <summary>
                    /// <para>A reserved field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/</para>
                    /// </summary>
                    [NameInMap("MassId")]
                    [Validation(Required=false)]
                    public long? MassId { get; set; }

                    /// <summary>
                    /// <para>A reserved field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/</para>
                    /// </summary>
                    [NameInMap("Memo")]
                    [Validation(Required=false)]
                    public string Memo { get; set; }

                    /// <summary>
                    /// <para>The message ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3727683838</para>
                    /// </summary>
                    [NameInMap("MsgId")]
                    [Validation(Required=false)]
                    public long? MsgId { get; set; }

                    /// <summary>
                    /// <para>The read status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: unread</description></item>
                    /// <item><description>1: read.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    /// <summary>
                    /// <para>The message title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;标题示例“</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5F62766-1C2F-1F56-A39D-63E3D30F0633</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
