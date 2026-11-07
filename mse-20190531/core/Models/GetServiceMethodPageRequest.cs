// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetServiceMethodPageRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want the results to be displayed. Valid values: zh and en. zh indicates Chinese, which is the default value. en indicates English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hkhonxxxxx@f3f75ed8ffxxxxx</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The IP address of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.5.5.5</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The full name of the Controller class to which the interface belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibabacloud.mse.demo.a.AController</para>
        /// </summary>
        [NameInMap("MethodController")]
        [Validation(Required=false)]
        public string MethodController { get; set; }

        /// <summary>
        /// <para>The method name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aMethod</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Microservices Engine (MSE) namespace to which the application belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request path that corresponds to the interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/a</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The group to which the service belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("ServiceGroup")]
        [Validation(Required=false)]
        public string ServiceGroup { get; set; }

        /// <summary>
        /// <para>The name of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sc-A</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>springCloud</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

    }

}
