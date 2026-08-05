// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveMessageAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of interactive messaging applications.</para>
        /// </summary>
        [NameInMap("AppList")]
        [Validation(Required=false)]
        public List<ListLiveMessageAppsResponseBodyAppList> AppList { get; set; }
        public class ListLiveMessageAppsResponseBodyAppList : TeaModel {
            /// <summary>
            /// <para>The ID of the interactive messaging application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The AppKey of the interactive messaging application. This value is required for authentication of related operations on this application.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testApp</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The signature of the interactive messaging application. This value is required by the interactive messaging SDK.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("AppSign")]
            [Validation(Required=false)]
            public string AppSign { get; set; }

            /// <summary>
            /// <para>The creation time, represented as a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1698305471</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The data center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DataCenter")]
            [Validation(Required=false)]
            public string DataCenter { get; set; }

            /// <summary>
            /// <para>Indicates whether the interactive messaging application is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Disable")]
            [Validation(Required=false)]
            public string Disable { get; set; }

            /// <summary>
            /// <para>The modification time, represented as a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1698305471</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The storage duration tier for group messages within the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Default value. Messages are stored for 30 days.</description></item>
            /// <item><description>1: Messages are stored for 90 days.</description></item>
            /// <item><description>2: Messages are stored for 180 days.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MsgLifeCycle")]
            [Validation(Required=false)]
            public int? MsgLifeCycle { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether there is a next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The starting position of the next page. This parameter is returned only when HasMore is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public long? NextPageToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8EB4994-1368-1458-B9F3-5B88D76D734C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
