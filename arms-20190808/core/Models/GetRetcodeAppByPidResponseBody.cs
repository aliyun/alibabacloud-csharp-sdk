// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRetcodeAppByPidResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2983BEF7-4A0D-47A2-94A2-8E9C5E63****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned application data.</para>
        /// </summary>
        [NameInMap("RetcodeApp")]
        [Validation(Required=false)]
        public GetRetcodeAppByPidResponseBodyRetcodeApp RetcodeApp { get; set; }
        public class GetRetcodeAppByPidResponseBodyRetcodeApp : TeaModel {
            /// <summary>
            /// <para>The ID of the application. The parameter is an auto-increment parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2787XXXX</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application that is monitored by Browser Monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testRetcodeAppXXXX</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The process identifier (PID) of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b590lhguqs@9781be0f44dXXXX</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The ID of the resource group. You can obtain the resource group ID in the <b>Resource Management</b> console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxidtzXXXX</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The type of the application that is monitored by Browser Monitoring. Valid values:</para>
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
            /// <para>The tags that are attached to the instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetRetcodeAppByPidResponseBodyRetcodeAppTags> Tags { get; set; }
            public class GetRetcodeAppByPidResponseBodyRetcodeAppTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
