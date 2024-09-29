// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListRetcodeAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99A663CB-8D7B-4B0D-A006-03C8EE38E7BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of applications monitored by Browser Monitoring.</para>
        /// </summary>
        [NameInMap("RetcodeApps")]
        [Validation(Required=false)]
        public List<ListRetcodeAppsResponseBodyRetcodeApps> RetcodeApps { get; set; }
        public class ListRetcodeAppsResponseBodyRetcodeApps : TeaModel {
            /// <summary>
            /// <para>The ID of the application. The parameter is an auto-increment parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16064</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A1</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The alias of the application monitored by Browser Monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B1</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The process identifier (PID) of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>atc889zkcf@d8deedfa9bf****</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxyexli2****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The type of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>web</c>: web application</description></item>
            /// <item><description><c>weex</c>: Weex mobile app</description></item>
            /// <item><description><c>mini_dd</c>: DingTalk mini program</description></item>
            /// <item><description><c>mini_alipay</c>: Alipay mini program</description></item>
            /// <item><description><c>mini_wx</c>: WeChat mini program</description></item>
            /// <item><description><c>mini_common</c>: mini program on other platforms</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("RetcodeAppType")]
            [Validation(Required=false)]
            public string RetcodeAppType { get; set; }

            /// <summary>
            /// <para>The tags of the task.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListRetcodeAppsResponseBodyRetcodeAppsTags> Tags { get; set; }
            public class ListRetcodeAppsResponseBodyRetcodeAppsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
