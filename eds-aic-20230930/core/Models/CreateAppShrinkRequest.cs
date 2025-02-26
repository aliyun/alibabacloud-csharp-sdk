// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAppShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application Name 1</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        [NameInMap("CustomAppInfo")]
        [Validation(Required=false)]
        public string CustomAppInfoShrink { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name used by the application file in OSS. This parameter, combined with <c>FilePath</c>, uniquely identifies the OSS path of the application file.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Log on to the <a href="https://eds.console.aliyun.com/osshelp">Cloud Phone console</a> and follow the on-screen instructions to upload the application file to Application Center to obtain the value of this parameter.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify <c>OssAppUrl</c>, you must specify <c>FileName</c> and <c>FilePath</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testApp.apk</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The OSS bucket path to the application file. This parameter, combined with <c>FileName</c>, uniquely identifies the OSS path of the application file.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Log on to the <a href="https://eds.console.aliyun.com/osshelp">Cloud Phone console</a> and follow the on-screen instructions to upload the application file to Application Center to obtain the value of this parameter.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify <c>OssAppUrl</c>, you must specify <c>FileName</c> and <c>FilePath</c>.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The icon URL of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com/icon.png">https://www.example.com/icon.png</a></para>
        /// </summary>
        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// <para>The parameters used for installing the application. By default, the <c>-r</c> parameter is included when you install an application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-d</para>
        /// </summary>
        [NameInMap("InstallParam")]
        [Validation(Required=false)]
        public string InstallParam { get; set; }

        /// <summary>
        /// <para>The endpoint of the OSS bucket to which you want to upload the application file.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Log on to the <a href="https://eds.console.aliyun.com/osshelp">Cloud Phone console</a> and follow the on-screen instructions to upload the application file to Application Center to obtain the value of this parameter.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify <c>FileName</c> or <c>FilePath</c>, you must specify this parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://testApp.apk">http://testApp.apk</a></para>
        /// </summary>
        [NameInMap("OssAppUrl")]
        [Validation(Required=false)]
        public string OssAppUrl { get; set; }

    }

}
