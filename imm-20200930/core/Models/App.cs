// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class App : TeaModel {
        /// <summary>
        /// <para>The application description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The largest e-commerce shopping mall in China</para>
        /// </summary>
        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The key returned when the application is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ryBOBW0Z6NnQ3fV9</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Taobao</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The region where the application is used. Valid values: 0: Chinese mainland. 1: Outside the Chinese mainland.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AppRegion")]
        [Validation(Required=false)]
        public long? AppRegion { get; set; }

        /// <summary>
        /// <para>The application type. Valid values: 0: Android. 1: iOS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public long? AppType { get; set; }

        /// <summary>
        /// <para>The English name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Taobao</para>
        /// </summary>
        [NameInMap("EnglishName")]
        [Validation(Required=false)]
        public string EnglishName { get; set; }

        /// <summary>
        /// <para>The customer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1023210024677934</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>PackageName</para>
        /// 
        /// <b>Example:</b>
        /// <para>ThisIsAPackageName</para>
        /// </summary>
        [NameInMap("PackageName")]
        [Validation(Required=false)]
        public string PackageName { get; set; }

    }

}
