// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDataSourceRequest : TeaModel {
        /// <summary>
        /// The ID of the data source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The environment in which the data source is used. Valid values: 0 and 1. 0 indicates the development environment. 1 indicates the production environment.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// The subtype of the data source. Example:
        /// 
        /// *   This parameter takes effect only if the DataSourceType parameter is set to rds.
        /// *   If the DataSourceType parameter is set to rds, this parameter can be set to mysql, sqlserver, or postgresql.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   odps
        /// *   mysql
        /// *   rds
        /// *   oss
        /// *   sqlserver
        /// *   polardb
        /// *   oracle
        /// *   mongodb
        /// *   emr
        /// *   postgresql
        /// *   analyticdb_for_mysql
        /// *   hybriddb_for_postgresql
        /// *   holo
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the data source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The details of the data source. Examples of details of some common data sources:
        /// 
        /// *   odps
        /// 
        /// ```
        /// 
        /// {
        ///   "accessId": "xssssss",
        ///   "accessKey": "xsaxsaxsa",
        ///   "authType": 2,
        ///   "endpoint": "http://service.odps.aliyun.com/api",
        ///   "project": "xsaxsax",
        ///   "tag": "public"
        /// }
        /// ```
        /// 
        /// *   mysql
        /// 
        /// ```
        /// 
        /// {
        ///   "database": "xsaxsa",
        ///   "instanceName": "rm-xsaxsa",
        ///   "password": "xsaxsa",
        ///   "rdsOwnerId": "xasxsa",
        ///   "regionId": "cn-shanghai",
        ///   "tag": "rds",
        ///   "username": "xsaxsa"
        /// }
        /// ```
        /// 
        /// *   rds
        /// 
        /// ```
        /// 
        /// {
        ///   "configType": 1,
        ///   "tag": "rds",
        ///   "database": "xsaxsa",
        ///   "username": "xsaxsa",
        ///   "password": "xssaxsa$32050",
        ///   "instanceName": "rm-xsaxs",
        ///   "rdsOwnerId": "11111111"
        /// }
        /// ```
        /// 
        /// *   oss
        /// 
        /// ```
        /// 
        /// {
        ///   "accessId": "sssssxx",
        ///   "accessKey": "xsaxaxsaxs",
        ///   "bucket": "xsa-xs-xs",
        ///   "endpoint": "http://oss-cn-shanghai.aliyuncs.com",
        ///   "tag": "public"
        /// }
        /// ```
        /// 
        /// *   sqlserver
        /// 
        /// ```
        /// 
        /// {
        ///   "jdbcUrl": "jdbc:sqlserver://xsaxsa-xsaxsa.database.xxx.cn:123;DatabaseName=xsxs-xsxs",
        ///   "password": "sdasda$fs",
        ///   "tag": "public",
        ///   "username": "sxaxacdacdd"
        /// }
        /// ```
        /// 
        /// *   polardb
        /// 
        /// ```
        /// 
        /// {
        ///   "clusterId": "pc-sdadsadsa",
        ///   "database": "dsadsadsa",
        ///   "ownerId": "121212122",
        ///   "password": "sdasdafssa",
        ///   "region": "cn-shanghai",
        ///   "tag": "polardb",
        ///   "username": "asdadsads"
        /// }
        /// ```
        /// 
        /// *   oracle
        /// 
        /// ```
        /// 
        /// {
        ///   "jdbcUrl": "jdbc:oracle:saaa:@xxxxx:1521:PROD",
        ///   "password": "sxasaxsa",
        ///   "tag": "public",
        ///   "username": "sasfadfa"
        /// }
        /// ```
        /// 
        /// *   mongodb
        /// 
        /// ```
        /// 
        /// {
        ///   "address": "[\\"xsaxxsa.mongodb.rds.aliyuncs.com:3717\\"]",
        ///   "database": "admin",
        ///   "password": "sadsda@",
        ///   "tag": "public",
        ///   "username": "dsadsadas"
        /// }
        /// ```
        /// 
        /// *   emr
        /// 
        /// ```
        /// 
        /// {
        ///   "accessId": "xsaxsa",
        ///   "emrClusterId": "C-dsads",
        ///   "emrResourceQueueName": "default",
        ///   "emrEndpoint": "emr.aliyuncs.com",
        ///   "accessKey": "dsadsad",
        ///   "emrUserId": "224833315798889783",
        ///   "name": "sasdsadsa",
        ///   "emrAccessMode": "simple",
        ///   "region": "cn-shanghai",
        ///   "authType": "2",
        ///   "emrProjectId": "FP-sdadsad"
        /// }
        /// ```
        /// 
        /// *   postgresql
        /// 
        /// ```
        /// 
        /// {
        ///   "jdbcUrl": "jdbc:postgresql://xxxx:1921/ssss",
        ///   "password": "sdadsads",
        ///   "tag": "public",
        ///   "username": "sdsasda"
        /// }
        /// ```
        /// 
        /// *   analyticdb_for_mysql
        /// 
        /// ```
        /// 
        /// {
        ///   "instanceId": "am-sadsada",
        ///   "database": "xsxsx",
        ///   "username": "xsxsa",
        ///   "password": "asdadsa",
        ///   "connectionString": "am-xssxsxs.ads.aliyuncs.com:3306"
        /// }
        /// ```
        /// 
        /// *   hybriddb_for_postgresql
        /// 
        /// ```
        /// 
        /// {
        ///   "connectionString": "gp-xsaxsaxa-master.gpdbmaster.rds.aliyuncs.com",
        ///   "database": "xsaxsaxas",
        ///   "password": "xsaxsaxsa@11",
        ///   "instanceId": "gp-xsaxsaxsa",
        ///   "port": "541132",
        ///   "ownerId": "xsaxsaxsas",
        ///   "username": "sadsad"
        /// }
        /// ```
        /// 
        /// *   holo
        /// 
        /// ```
        /// 
        /// {
        ///   "accessId": "xsaxsaxs",
        ///   "accessKey": "xsaxsaxsa",
        ///   "database": "xsaxsaxsa",
        ///   "instanceId": "xsaxa",
        ///   "tag": "aliyun"
        /// }
        /// ```
        /// 
        /// *   kafka
        /// 
        /// ```
        /// 
        /// {
        ///   "instanceId": "xsax-cn-xsaxsa",
        ///   "regionId": "cn-shanghai",
        ///   "tag": "aliyun",
        ///   "ownerId": "1212121212112"
        /// }
        /// ```
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

    }

}
