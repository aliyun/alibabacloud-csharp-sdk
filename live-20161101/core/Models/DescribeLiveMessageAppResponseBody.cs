// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveMessageAppResponseBody : TeaModel {
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
        /// <para>The AppKey of the interactive messaging application. It is used to authorize operations related to the application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The name of the interactive messaging application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The signature of the interactive messaging application. It is required by the interactive messaging SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AppSign")]
        [Validation(Required=false)]
        public string AppSign { get; set; }

        /// <summary>
        /// <para>The content moderation method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Content moderation is disabled.</description></item>
        /// <item><description>1: Built-in content moderation is used.</description></item>
        /// <item><description>2: Custom content moderation is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AuditType")]
        [Validation(Required=false)]
        public int? AuditType { get; set; }

        /// <summary>
        /// <para>The URL for content moderation. This parameter is returned when the value of AuditType is 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.aliyundoc.com/exampleaudit">http://example.aliyundoc.com/exampleaudit</a></para>
        /// </summary>
        [NameInMap("AuditUrl")]
        [Validation(Required=false)]
        public string AuditUrl { get; set; }

        /// <summary>
        /// <para>The time when the interactive messaging application was created. The value is a UNIX timestamp. Unit: seconds.</para>
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
        public bool? Disable { get; set; }

        /// <summary>
        /// <para>The callback URL for events such as user logon, logoff, joining a group, and leaving a group. An empty value indicates that callbacks are disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.aliyundoc.com/examplecallback">http://example.aliyundoc.com/examplecallback</a></para>
        /// </summary>
        [NameInMap("EventCallbackUrl")]
        [Validation(Required=false)]
        public string EventCallbackUrl { get; set; }

        /// <summary>
        /// <para>The time when the interactive messaging application was modified. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698305471</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The retention period of group messages in the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): 30 days</description></item>
        /// <item><description>1: 90 days</description></item>
        /// <item><description>2: 180 days</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MsgLifeCycle")]
        [Validation(Required=false)]
        public int? MsgLifeCycle { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FB68B5B-ED07-18F0-A3CF-083F4E74****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
